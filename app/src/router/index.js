import { createRouter, createWebHistory } from 'vue-router'
import HomeView from '../views/HomeView.vue'
import PeixesView from '../views/PeixesView'
import cadastroView from '../views/CadastroView'
import loginView from '../views/LoginView'
const routes = [
  {
    path: '/',
    name: 'home',
    component: HomeView
  },
  {
    path: '/login',
    name:'login',
    component: loginView
  },
  {
    path: '/cadastro',
    name: 'cadastro',
    component: cadastroView
  },
  {
    path: '/peixes',
    name: 'peixes',
    // route level code-splitting
    // this generates a separate chunk (about.[hash].js) for this route
    // which is lazy-loaded when the route is visited.
    component: () => import(/* webpackChunkName: "about" */ '../views/PeixesView.vue'),
    children:[
      {
        path:':id', name:'peixess', component:PeixesView
      }
    ]
  },
  {
    path: '/Contato',
    name: 'Contato',
    component: () => import(/* webpackChunkName: "about" */ '../views/ContatosView.vue')
  },
  {
    path: '/QuemSomos',
    name: 'QuemSomos',
    component: () => import(/* webpackChunkName: "about" */ '../views/QuemSomosView.vue')
    
  }
]

const router = createRouter({
  history: createWebHistory(process.env.BASE_URL),
  routes
})

export default router
