var map = L.map('map').setView([21.70735, 120.062965], 5.2);
var layer = L.esri.Vector.basemap('OpenStreetMap').addTo(map);

map.pointID;
map.focusicon=[]
map.day=-90;
map.dot = 1000;
let config = {
	'headers': {
		'accept': 'application/json',
		'CK': 'PKHFGYZE2AU3TMMM0A'
	}
};
map.genID = function(length){
    return Number(Math.random().toString().substr(3,length) + Date.now()).toString(36);
}

function setBasemap (basemap) {
    if (layer) {
        map.removeLayer(layer);
    }
    layer = L.esri.Vector.basemap(basemap);
    map.addLayer(layer);
}

$('#day').change(function(c){
    map.day = c.target.value;
})//儲存使用者動態選擇的過往天數
$('#group').change(function(c){
    map.focusVesselGroup.settarget(c).getVesselList();
})//儲存使用者動態選擇的船隊

// let config = {
// 	'headers': {
// 		'accept': 'application/json',
// 		'CK': 'PKZAK92KUKF3HMB99U'
// 	}
// };

map.focusDot = {
}

map.focusVesselGroup = {
    target: "Loyal",
    data: [
        "1099"
    ],
    claertarget: function(){
        this.data=[]
        this.target="undefind"
    },
    getdata: function(){
        return this.data
    },
    settarget: function(value){
        this.target=value;
        return this
    },
    getVesselList: function(){
    }
}
map.focusVesselList = {
    data: [
        
    ]
}

map.focusVessel = {
    target:"",
    data: {
        "type": "FeatureCollection",
        "features": [
        ]
    },
    pointdata: [

    ],
    cleartarget: function(){
        this.target="";
        return this
    },
    cleardata: function(){
        this.data={
            "type": "FeatureCollection",
            "features": [
            ]
        };
        return this
    },
    clearpointdata: function(){
        this.pointdata=[

        ];
        return this
    },
    removepointfrommap: function(){
        if(this.pointdata.length>0){
            for(i=0;i<this.pointdata.length;i++){
                this.pointdata[i]._path.remove();
            }
        }
        return this
    },
    getdata: function(){
        return this.data
    },
    pushpointdata: function(lonlat){
        this.pointdata.push(lonlat);
        return this
    },
    settarget: function(value){
        this.target = value
        return this
    },
    pushfeatures: function(features){
        this.data.features.push(features);
        return this
    },
    time_line_Init: function(data){
        var slider = L.timelineSliderControl({
            formatOutput: function (date) {
            return moment(date).format("YYYY-MM-DDTHH:MM:SS");
            },
        });
        map.addControl(slider);

        var pointTimeline = L.timeline(data,{
            pointToLayer: function (data, latlng) {
                var target = L.marker(latlng, { icon: L.icon({
                    iconUrl: './image/triangle.svg',
                    iconSize: [25, 25]
                  }) }).addTo(map)
                map.focusicon.push(target)
                // .bindPopup(
                //   '<a href="' + data.properties.url + '">click for more info</a>'
                // );
              }
        });
        pointTimeline.addTo(map);
        slider.addTimelines(pointTimeline);
        pointTimeline.on("change", function (e) {
            if(map.focusicon.length>1)
            {
              for(i=0;i<(map.focusicon.length-1);i++){
                map.focusicon[i]._icon.remove()
              }
            }
            map.setView([map.focusicon[map.focusicon.length-1]._latlng.lat,map.focusicon[map.focusicon.length-1]._latlng.lng],5.5);
            map.focusicon=[map.focusicon[map.focusicon.length-1]];
        });
    }
}


map.getDateInterval = function(day,dotcount){
    let changeDay = day;
    timepart = changeDay/(dotcount-1);
    let data =[];
    for(i=0;i<dotcount;i++){
        value = i*timepart
        let theDay = new Date()   
        let changeDay = value        
        theDay.setDate(theDay.getDate() + changeDay);
        start = theDay.toISOString();
        theDay.setSeconds(theDay.getSeconds() + 5000);
        end = theDay.toISOString();
        data.push({
            "start":start.split('.')[0]+"Z",
            "end":end.split('.')[0]+"Z"
        })
    }
    return data
}

data = new Date();
console.log(data)
