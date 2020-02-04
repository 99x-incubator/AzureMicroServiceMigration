import Vue from 'vue'
import App from './App'
import router from './router'
import VueResource from 'vue-resource';

Vue.use(VueResource);

Vue.config.productionTip = false
Vue.http.options.root = 'http://localhost:3334/';


/* eslint-disable no-new */
new Vue({
  el: '#app',
  router,
  components: { App },
  template: '<App/>'
})
