<template>
  <div>
    <div id="gjs"></div>
  </div>
</template>

<script>

import Grapesjs from 'grapesjs';
var editor = grapesjs.init({
  container : '#gjs',
  components: '<div class="txt-red">Hello world!</div>',
  style: '.txt-red{color: red}',
});
module.exports = {
  data () {
    return {
      msg: ''
    }
  }
}
</script>

<style>
</style>