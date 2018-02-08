import Vue from 'vue'
import Router from 'vue-router'
import Home from '@/components/Home'
import UserList from '@/components/UserList'

Vue.use(Router)

export default new Router({
  mode: 'history',
  routes: [
    {
      path: '/',
      name: 'Home',
      component: Home
    },
    {
      path: '/user-list',
      name: 'UserList',
      component: UserList
    }
  ]
})
