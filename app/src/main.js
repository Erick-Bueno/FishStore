
import { createApp } from 'vue'
import App from './App.vue'
import router from './router'
import store from './store'
import axios from 'axios'
import BootstrapVue3 from "bootstrap-vue-3";

import "bootstrap/dist/css/bootstrap.css";
import "bootstrap-vue-3/dist/bootstrap-vue-3.css";


axios.interceptors.response.use(function (response) {
    return response;
}, function (error) {
    return new Promise((resolve, reject) => {
        const reqOrigi = error.config
        if(error.response.status == 401){
            let token = store.state.user.token
            
            
             let res = axios.post("https://localhost:7179/api/Usuario/refresh", {
                oldtoken: token
            }).then(function(res){
                store.commit('setToken', res.data)
                reqOrigi.headers["Authorization"] = `Bearer ${store.state.user.token}`
              
                return axios(reqOrigi)
                
                
            })
            
           resolve(res)
        }return reject(error)
    })
});



createApp(App).use(store).use(router).use(BootstrapVue3).mount('#app')
