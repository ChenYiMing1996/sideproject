let config = {
	'headers': {
		'accept': 'application/json',
		'CK': 'PKKCYFEY3HYWC7P93U'
	}
};



let app = new Vue({
	el: '#app',
	data: {
		vesselList: [],
		selectVessel: 0,
		deviceIdList: [],
		sensorList: [],
		device: []
	},
	mounted() {
		this.getVesselList();
		this.getSensorList("9999");
	},
	methods: {
		getVesselList: function() {
			axios
				.get('https://iot.cht.com.tw/iot/v1/device?sk=device_type&sv=topvessel&dist=2000', config) // 查詢所有船號
				.then((response) => {
					let responseData = response.data;
					console.log(responseData);
					for (let i = 0, length = responseData.length; i < length; ++i) {
						this.vesselList.push(responseData[i].attributes[4].value)
					}
				});
		},
		createCsvFile: function() {
			var fileName = "vessel-report-dl_20200620.csv";
			var data = this.createCsvContent();
			var blob = new Blob([data], {
			  type : "application/octet-stream"
			});
			var href = URL.createObjectURL(blob);
			var link = document.createElement("a");
			document.body.appendChild(link);
			link.href = href;
			link.download = fileName;
			link.click();
		},
		getData: function() {
			this.getDeviceList().then((result) => {
				let deviceIdList = result;
				let sensorDataList = [];
				let count = 0;
				for (let i = 0, deviceLength = deviceIdList.length; i < deviceLength; ++i) {
					this.getSensorList(deviceIdList[i]).then((result) => {
						sensorDataList = sensorDataList.concat(result);
						++count;
						if (count == deviceLength) {
							console.log(JSON.stringify(sensorDataList));
							// for (let j = 0, sensorLength = sensorDataList.length; j < sensorLength; ++j) {
							// 	console.log(new Date().getTime());
							// 	this.getSensorValue(sensorDataList[j].deviceId, sensorDataList[j].sensorId).then((result) => {
							// 		console.log(result);
							// 	})
							// }
						}
					})
				}
			});
		},
		getDeviceList: function() {
			return axios
				.get(`https://iot.cht.com.tw/iot/v1/device?sk=vessel_id&sv=${this.selectVessel}&dist=2000`, config) // 查詢單艘船所有設備
				.then((response) => {
					let responseData = response.data;
					let deviceIdList = [];
					for (let i = 0, length = responseData.length; i < length; ++i) {
						if (responseData[i].attributes[0].value == 'device') {
							deviceIdList.push(responseData[i].id);
						}
					}
					return deviceIdList;
				});
		},
		getSensorList: function(deviceId) {
			axios
				.get("https://iot.cht.com.tw/iot/v1/device/" + deviceId + "/sensor", config) // 查詢單設備所有sensor
				.then((response) => {
					let responseData = response.data;
					let sensorDataList = [];
					for (let i = 0, length = responseData.length; i < length; ++i) {
						sensorDataList.push(
							{
								'deviceId': deviceId,
								'sensorId': responseData[i].id
							}
						);
					}
					console.log(responseData);
				});
		},
		getSensorValue: function(deviceId, sensorId) {
			 	axios
				.get(`https://iot.cht.com.tw/iot/v1/device/${deviceId}/sensor/${sensorId}/rawdata`, config) // 查詢單設備所有sensor
				.then((response) => {
					console.log(response.data);
				});
		},
		createCsvContent: function() {
			let csvContent = '';
			let date = '\ufeff日期,2020/6/20\n';
			csvContent += date;
			let title = ',,CHNO,NAME,00:00,04:00,08:00,12:00,16:00,20:00,UNIT\n';
			csvContent += title;
			for (let i = 0; i < 50; i++) {
				for (let j = 0; j < 5; j++) {
					if(j > 0){
				  		csvContent = csvContent + ",";
				  	}
				  	csvContent = csvContent + "Item" + i + "_" + j;
				}
				csvContent = csvContent + "\n";
			}
			return csvContent;
		},
		changeVessel: function() {
			this.getDeviceList().then((result) => {
				this.deviceIdList = result;
			})
		},
		clickDevice: function(deviceId) {
			this.getSensorList(deviceId).then((result) => {
				this.sensorList = this.sensorList.concat(result);
				console.log(this.sensorList);
			})
		},
		grId: function(index) {
			return 'device' + index;
		},
		test: function() {
			this.device[2] = false;
			console.log(this.device);
		}
	}
})