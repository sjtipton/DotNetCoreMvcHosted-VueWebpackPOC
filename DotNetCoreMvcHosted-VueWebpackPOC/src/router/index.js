import Vue from 'vue'
import Router from 'vue-router'
import Todos from '@/components/Todos'
import HelloWorld from '@/components/HelloWorld'

Vue.use(Router)

export default new Router({
  routes: [
    {
      path: '/',
      name: 'HelloWorld',
      component: HelloWorld
    },
    {
      path: '/todos',
      name: 'Todos',
      component: Todos
    }
  ]
})
