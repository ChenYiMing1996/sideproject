<template>
    <div>
      <div class="container my_container d-lg-block d-none">
        <div class="row">
          <div class="col-sm-12">
            <b-img  src="../../../static/img/event1.jpg" alt="Fluid image" class="my_image"></b-img>
          </div>
        </div>
      </div>
    </div>
</template>
<script>
export default {
  name: 'SaleEvent2',
  data () {
    return {
      msg: 'SaleEvent2'
    }
  }
}
</script>
<style scoped>
  .my_image{
    min-height: 100px;
    max-height: 180px;
  }
  .my_container
  {
    text-align:center;
    padding-top: 4%;
  }
  </style>
