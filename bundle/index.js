import $ from 'jquery';
import 'bootstrap3/dist/js/bootstrap';
import 'bootstrap3/dist/css/bootstrap.min.css';
import Vue from 'vue';
import entry from './entry.vue';
import './assets/grapes.css';
//require('bootstrap-loader');

/* eslint-disable no-new */
new Vue({
  el: '#app',
  render: h => h(entry)
})