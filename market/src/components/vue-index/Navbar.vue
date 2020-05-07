<template>
    <div>
      <b-nav class="navbav_mydefault">
        <b-nav-item active>Logo</b-nav-item>
        <b-nav-item>List</b-nav-item>
        <b-nav-item>Focus</b-nav-item>
        <b-nav-item>Cart </b-nav-item>
      </b-nav>
      <b-nav class="navbav_mydefault type_border">
        <b-nav-item >productype1</b-nav-item>
        <b-nav-item >productype2</b-nav-item>
        <b-nav-item >productype3</b-nav-item>
        <b-nav-item >productype4 </b-nav-item>
        <b-nav-item >productype5 </b-nav-item>
      </b-nav>
    </div>
</template>
<script>
export default {
  name: 'myNavbar',
  data () {
    return {
      msg: 'myNavbar'
    }
  }
}
</script>
<style scoped>
  .navbav_mydefault
  {
    min-height: 50px;
    background-color:slategray;
  }
  .type_border
  {
    background-color:whitesmoke;
    border-bottom:1px solid #ccc!important;
    border:black;
    min-height: 60px;
    max-height: 120px;
  }
  a{
    color: black;
  }
  </style>
