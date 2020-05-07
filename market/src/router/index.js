import Vue from 'vue'
import Router from 'vue-router'
import index from '@/components/index'
import pddisplay from '@/components/pddisplay'
import singlepd from '@/components/singlepd'
import cart from '@/components/cart'

Vue.use(Router)

export default new Router({
  routes: [
    {
      path: '/',
      name: 'index',
      component: index
    },
    {
      path: '/pddisplay',
      name: 'pddisplay',
      component: pddisplay
    },
    {
      path: '/singlepd',
      name: 'singlepd',
      component: singlepd
    },
    {
      path: '/cart',
      name: 'cart',
      component: cart
    },
    { path: '*', redirect: '/' }
  ]
})
