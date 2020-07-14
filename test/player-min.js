//Status constants
var SESSION_STATUS = Flashphoner.constants.SESSION_STATUS;
var STREAM_STATUS = Flashphoner.constants.STREAM_STATUS;
 
//Websocket session 
var session;
 

function init_api() {
    console.log("init api");
        Flashphoner.init({
        });
}

connect()
function connect() {
    playStream()
    session = Flashphoner.createSession({urlServer: "wss://demo.flashphoner.com"}).on(SESSION_STATUS.ESTABLISHED, function(session){       
        console.log("connection established");
        playStream(session);
    });
}

function playStream() {
    var options = {name:"rtsp://184.72.239.149/vod/mp4:BigBuckBunny_115k.mov",display:document.getElementById("myVideo")};    
    var stream = session.createStream(options).on(STREAM_STATUS.PLAYING, function(stream) {
        console.log(stream);
    });
    stream.play();
}


// Flashphoner.init({
//     flashMediaProviderSwfLocation: "../../media-provider.swf"
// });
// var display = document.getElementById("localCamera");
// Flashphoner.getMediaAccess({
//     audio: true,
//     video: {
//         width: 640,
//         height: 480
//     }
// }, display, "Flash").then(function(){
//     display.children[0].addEventListener('resize', function(event){
//         var padding = event.target.videoHeight / event.target.videoWidth * 100;
//         console.log("padding is " + padding);
//         display.style.cssText = "padding-bottom: "+padding+"%;";
//     });
// });
