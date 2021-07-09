import { createApp } from 'vue'
import App from './App.vue'
import router from './router'
const app = createApp(App)
app.use(router).mount('#app')

import { createStore } from 'vuex'
const store = createStore({
    state () {
      return {
        count: 0
      }
    },
    mutations: {
      increment (state) {
        state.count++
      }
    }
  })

  app.use(store)
  //console.log("XXXXXXX" + store.state.count);
