<template>
    <div>
      <div class="container">
        <div class="BorderTop_row row">
          <div class="BorderTop_col col_fix">
            <b-img src="../../../static/img/topborder.jpg" fluid alt="Fluid image" class="BorderTop_image"></b-img>
          </div>
        </div>
      </div>
    </div>
</template>
<script>
export default {
  name: 'BorderTop',
  data () {
    return {
      msg: 'BorderTop'
    }
  }
}
</script>
<style scoped>
  .BorderTop_row
  {
    background-color:white;
    margin-bottom: 4%;
  }
  .BorderTop_col
  {
    background-color:lightgray;
    min-height: 400px;
    max-height: 800px;
  }
  .BorderTop_image
  {
    min-width: 950px;
    min-height: 400px;
    max-height: 800px;
  }
  .col_fix{
    padding-right: 0px;
    padding-left: 0px;
  }
</style>
