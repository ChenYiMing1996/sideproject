
$(function(){
    $(window).load(function(){
        $(window).bind("scroll resize", function(){
            var $this = $(this);
            var $this_Top=$this.scrollTop();
            if($this_Top < 100){
                $(".header").stop().animate({top:"-65px"});
            }
        　　if($this_Top > 100){
            　　$(".header").stop().animate({top:"0px"});
            }       
        }).scroll();
    });
});