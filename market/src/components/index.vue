<template>
  <div class="index">
    <myNavbar/>
    <BorderTop/>
    <ProducAList/>
    <SaleEvent1/>
    <ProducBList/>
    <SaleEvent2/>
    <ProducCList/>
  </div>
</template>

<script>
export default {
  name: 'index',
  data () {
    return {
      msg: 'Welcome to Your Vue.js App'
    }
  }
}
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
.activity-image{
  min-height: 100px;
  max-height: 180px;
}
.activity_border
{
  text-align:center;
  padding-top: 4%;
}
.align{
  vertical-align: middle;
}
</style>
