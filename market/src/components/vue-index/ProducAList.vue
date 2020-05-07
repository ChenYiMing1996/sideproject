<template>
    <div>
      <div class="container">
        <div class="row text-center">
          <div v-for="item in object" class="col-sm ProducAList_border">
            <div class="ProducAList_sell">
              <div class="row">
                <div class="col-sm-12">
                  <b-img v-bind:src= item.pic alt="Responsive image" class="ProducAList_image" ></b-img>
                </div>
              </div>
              <div class="col-sm-12">
                <h4>{{item.name}}</h4>
                <p>{{item.description}}</p>
              </div>
              <div class="col-sm-12 text-right">
                <p class="price">{{item.price}}$</p>
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>
</template>
<script>
export default {
  name: 'ProducAList',
  data () {
    return {
      object:
      [
        {pic: '../../../static/img/produc1.png', name: 'produc1', description: 'produc1-description', price: 1999},
        {pic: '../../../static/img/produc2.png', name: 'produc2', description: 'produc2-description', price: 2999},
        {pic: '../../../static/img/produc3.png', name: 'produc3', description: 'produc3-description', price: 3999},
        {pic: '../../../static/img/produc4.png', name: 'produc4', description: 'produc4-description', price: 4999},
        {pic: '../../../static/img/produc5.png', name: 'produc5', description: 'produc5-description', price: 5999},
        {pic: '../../../static/img/produc6.png', name: 'produc6', description: 'produc6-description', price: 6999}
      ]
    }
  }
}
</script>
<style scoped>
  .ProducAList_border{
    padding-bottom: 3%;
  }
  .ProducAList_image{
    width: 167px;
    height: 167px;
  }
  .ProducAList_sell{
    background-color:whitesmoke;
    min-width: 300px;
    max-width: 300xp;
    min-height: 230px;
    max-height: 400px;
    padding-top: 7%;
  }
  .price{
    color: coral;
    margin: 5px;
    padding: 5px;
  }
</style>
