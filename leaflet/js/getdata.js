
// let config = {
// 	'headers': {
// 		'accept': 'application/json',
// 		'CK': 'PKKCYFEY3HYWC7P93U'
// 	}
// };
let time = {
    data:{
        start: "2016-07-14T23:55:00Z",
        end: "2016-08-30T00:00:00Z"
    }
}
let develop = false;
let pointcolor ="red";
let pointopacity =1;
let app = new Vue({
	el: '#app',
	data: {
        vesselGroupList: [],
        vesselList: [],
        InstanceVessel: [],
        FocusVessel: {},
        day: [1,3,7,30,60,90]
	},
	mounted() {
        this.VesselInstance()
        // this.getVesselTrack("22807107295");//實體化船團
	},
	methods: {
        test: function() {
            
        },
        VesselInstance: function() {
            let vesselList = map.focusVesselGroup.getdata();
            for(i=0;i<vesselList.length;i++){
                axios.get("https://iot.cht.com.tw/iot/v1/device?sk=vessel_id&sv=" + vesselList[i] + "&dist=2000", config)
                .then((response) => {
                    // console.log(response)
                    // var data = map.getDateInterval(-365,5)    多數據比對船位置
                    // for(i=0;i<data.length;i++){
                    //     axios.get("https://iot.cht.com.tw/iot/v1/device/" + response.data[0].id + "/sensor/ECDIS-INGLL_UTC_of_this_position/rawdata?start=" + data[i].start + "&end=" + data[i].end, config)
                    //     .then((response) => {
                    //         console.log(response);
                    //     });
                    // }
                    axios.get("https://iot.cht.com.tw/iot/v1/device/" + response.data[0].id + "/sensor/ECDIS-INGLL_UTC_of_this_position/rawdata/saved", config)
                    .then((response)=>{
                        setTimeout(() => {
                            // console.log(response)
                            let data={};
                            if(develop){
                                data ={
                                    "type": "Feature",
                                    "geometry": {
                                        "type": "Point",
                                        "coordinates": [
                                            120.062965,
                                            21.70735
                                        ]
                                    },
                                    "properties": response
                                };
                            }else{
                                data ={
                                    "type": "Feature",
                                    "geometry": {
                                        "type": "Point",
                                        "coordinates": [
                                            response.data.lon,
                                            response.data.lat
                                        ]
                                    },
                                    "properties": response
                                };
                            }
                            let myLayerOptions = {
                                pointToLayer: this.createCustomIcon,
                                onEachFeature: this.vesselEvent
                            };
                            let icon = L.geoJSON(data, myLayerOptions).addTo(map);
                            // let id = icon._leaflet_id;
                            // console.log(icon._layers[id - 1].feature); 
                        }, 1500)
                    })
                })
            }
        },
        getVesselTrack: function(vessel_id) {
            var data = map.getDateInterval(map.day,map.dot);
            var sensorId = "ECDIS-INGLL_UTC_of_this_position";
            for(i=0;i<data.length;i++){
                axios.get("https://iot.cht.com.tw/iot/v1/device/" + vessel_id + "/sensor/" + sensorId + "/rawdata?start=" + data[i].start + "&end=" + data[i].end, config)
                .then((response) => {
                    console.log(response);
                });
            }
        },
        vesselEvent: function(feature, layer) {
            layer.on({
                click: function(feature){ 
                    // console.log(feature)
                    map.focusVessel.cleardata().removepointfrommap().clearpointdata().settarget(feature.target.feature);
                    var data = this._map.getDateInterval(map.day,map.dot);
                    for(i=0;i<data.length;i++){
                        map.pointID=i;
                        axios.get("https://iot.cht.com.tw/iot/v1/device/" + feature.target.feature.properties.data.deviceId + "/sensor/ECDIS-INGLL_UTC_of_this_position/rawdata?start=" + data[i].start + "&end=" + data[i].end,
                        config).then((response) => {
                            var style = {
                                "color": pointcolor,
                                "opacity": pointopacity,
                                "radius":"650"
                            }
                            if(response.data.length>1){
                                var data = response.data[0];
                                // var timestring = Date.parse(data.time)
                                // console.log(data.time)
                                // console.log(timestring)
                                // var iso8601 = new Date(timestring).toISOString().split('.')[0]+"Z";
                                // console.log(iso8601)
                                var feature ={
                                    "type": "Feature",      
                                    "geometry": {
                                        "type": "Point",
                                        "coordinates": [
                                            data.lon,
                                            data.lat
                                        ]
                                    },
                                    "properties": {
                                        "start":data.time,
                                        "end":data.time
                                    }
                                };
                                var point = L.circle([data.lat, data.lon],style).addTo(map);
                                // map.setView([data.lat,data.lon],4);
                                map.focusVessel.pushpointdata(point);
                                map.focusVessel.pushfeatures(feature);//將data寫入map.forcusvessel的資料集合
                            }
                        });
                    }
                    
                    setTimeout(() => {
                        console.log(map.focusVessel.getdata())
                        map.focusVessel.time_line_Init(map.focusVessel.data);
                    }, map.dot*40)
                }
            });
        },
        createCustomIcon: function(feature, latlng) {
            let myIcon = L.icon({
              iconUrl: './image/triangle.svg',
              iconSize: [25, 25]}
            )
            return L.marker(latlng, { icon: myIcon })
        },
        // getSensorList: function(deviceId) {
		// 	return axios
		// 		.get("https://iot.cht.com.tw/iot/v1/device/" + deviceId + "/sensor", config) // 查詢單設備所有sensor
		// 		.then((response) => {
		// 			let responseData = response.data;
		// 			let sensorDataList = [];
		// 			for (let i = 0, length = responseData.length; i < length; ++i) {
		// 				sensorDataList.push(
		// 					{
		// 						'deviceId': deviceId,
		// 						'sensorId': responseData[i].id
		// 					}
		// 				);
		// 			}
		// 			return sensorDataList;
		// 		});
        // },
        // getlatlon: function(deviceId ,sensorId){
        //     return axios.get("https://iot.cht.com.tw/iot/v1/device/" + deviceId + "/sensor/" + sensorId + "/rawdata", config)
        //     .then((response) => {
        //         if(develop){
        //             return {
        //                 "lat":100,
        //                 "lon":100
        //             }
        //         }else{
        //             return {
        //                 "lat":response.data.lat,
        //                 "lon":response.data.lon
        //             }
        //         }
        //     })
        // },
        // focus: function(lat, lng, scale){
        //     map.setView([lat,lng],scale);
        // }
		// getDeviceList: function(vessel_id) {
		// 	return axios
		// 		.get("https://iot.cht.com.tw/iot/v1/device?sk=vessel_id&sv=" + this.vesselList + "&dist=2000", config) // 查詢單艘船所有設備
		// 		.then((response) => {
		// 			let responseData = response.data;
		// 			let deviceIdList = [];
		// 			for (let i = 0, length = responseData.length; i < length; ++i) {
		// 				if (responseData[i].attributes[0].value == 'device') {
		// 					deviceIdList.push(responseData[i].id);
		// 				}
		// 			}
		// 			return deviceIdList;
		// 		});
		// },
		
		// getSensorValue: function(deviceId, sensorId) {
		// 	return axios
		// 		.get("https://iot.cht.com.tw/iot/v1/device/" + deviceId + "/sensor/" + sensorId + "/rawdata", config) // 查詢單設備所有sensor
		// 		.then((response) => {
		// 			return response.data;
		// 		});
        // },
        // getSensorbyTime: function(feature){
        //     console.log(feature.type);
        //     let deviceId = feature.properties;
        //     this.getSensorList(deviceId).then((response) => {
        //         console.log(response);
        //     })
        //     let sensorId = "AMS-0201";
        //     axios.get("https://iot.cht.com.tw/iot/v1/device/" + deviceId + "/sensor/" + sensorId + "/rawdata",
        //     config, time)
        //     .then((response) => {
        //         console.log(response)
        //     });
        // },
		// changeVessel: function() {
		// 	this.getDeviceList().then((result) => {
		// 		this.deviceIdList = result;
		// 	})
		// },
		// clickDevice: function(deviceId) {
		// 	this.getSensorList(deviceId).then((result) => {
		// 		this.sensorList = this.sensorList.concat(result);
		// 		console.log(this.sensorList);
		// 	})
		// },
		// grId: function(index) {
		// 	return 'device' + index;
		// },
		// test: function() {
		// 	this.device[2] = false;
		// 	console.log(this.device);
		// }
	}
})