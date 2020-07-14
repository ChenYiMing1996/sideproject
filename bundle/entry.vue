<template>
<div class="container">
  <!-- <grapes/> -->
  <div class="jumbotron">
    <h1>Title</h1>
    <p></p> 
  </div>
  <div class="row">
    <div class="col-sm-4">
      <h3>Column 1</h3>
      <p>Column 1 Content</p>
      <p>Column 1 Content</p>
    </div>
    <div class="col-sm-4">
      <h3>Column 2</h3>
      <p>Column 2 Content</p>
      <p>Column 2 Content</p>
    </div>
    <div class="col-sm-4">
      <h3>Column 3</h3> 
      <p>Column 3 Content</p>
      <p>Column 3 Content</p>
    </div>
  </div>
</div>
</template>

<script>
import grapes from './components/grapes.vue'
module.exports = {
  data () {
    return {
      msg: '這是第一個 Vue 元件檔！'
    }
  },
  components: { grapes }
}
</script>

<style>
h1 {
    color: blue !important;
}

p {
    background-color:azure;
    color: black !important;
}

h3 {
  font-size: 3em;
  text-align: center;
  color: green !important;
}
.row {
  
    background-color: whitesmoke;
}
</style>