// The Vue build version to load with the `import` command
// (runtime-only or standalone) has been set in webpack.base.conf with an alias.
import Vue from 'vue'
import App from './App'
import router from './router'
import { BootstrapVue, IconsPlugin } from 'bootstrap-vue'
import 'bootstrap/dist/css/bootstrap.css'
import 'bootstrap-vue/dist/bootstrap-vue.css'
import Navbar from './components/vue-index/Navbar'
import BorderTop from './components/vue-index/BorderTop'
import ProducAList from './components/vue-index/ProducAList'
import ProducBList from './components/vue-index/ProducBList'
import ProducCList from './components/vue-index/ProducCList'
import SaleEvent1 from './components/vue-index/SaleEvent1'
import SaleEvent2 from './components/vue-index/SaleEvent2'

Vue.config.productionTip = false
Vue.use(BootstrapVue)
Vue.use(IconsPlugin)
Vue.component('myNavbar', Navbar)
Vue.component('BorderTop', BorderTop)
Vue.component('ProducAList', ProducAList)
Vue.component('ProducBList', ProducBList)
Vue.component('ProducCList', ProducCList)
Vue.component('SaleEvent1', SaleEvent1)
Vue.component('SaleEvent2', SaleEvent2)

// eslint-disable-next-line
new Vue({
  el: '#app',
  router,
  components: { App },
  template: '<App/>'
})
