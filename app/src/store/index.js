import { createStore } from 'vuex'
import persist from 'vuex-persist'

const local = new persist({
  storage: window.localStorage
})

export default createStore({
  state: {
    user:{
      id: null,
      token: null
    }
  },
  getters: {
  },
  mutations: {
    setid(state, payload){
      state.user.id = payload
    },
    setToken(state, payload){
      state.user.token = payload
    }
  },
  actions: {
  },
  modules: {
  },
  plugins:[local.plugin]
})
