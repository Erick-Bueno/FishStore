<template>
   
    <header>
         <img class="logo" :src="logo" alt="">
         <nav :class="abrindo">
            <img @click="fechando" class="fechar" src="/imgs/marca-cruzada.png" alt="">
             <ul>
                 <router-link to="/">
                     <li>Home</li>
                 </router-link>
                 <router-link to="/QuemSomos">
                     <li>Quem Somos</li>
                 </router-link>
                 <router-link to="/peixes">
                     <li>Peixes</li>
                 </router-link>
                 <router-link to="/Contato">
                     <li>Contato</li>
                 </router-link>
                 
             </ul>
         </nav>
         <div v-show="!logtr" class="container-buttons">
            <button @click="$router.push('/login')" class="button-login">Login</button> <button @click="$router.push('/cadastro')" class="button-cadastrar">Cadastrar</button>
            
         </div>
         
         <div v-show="logtr" class="usuario">
             <p class="username">{{Nome}}</p>
             <span @click="mostrar" class="perfil">
                {{Nome[0]}}
                
             </span>
             <div class="config" v-show="mostrar_config">
                <p class="em">Email</p>
                <p class="em2">{{Email}}</p>
                <div><button @click="logoutt"  class="logOut"><img src="/imgs/saida.png" class="porta" alt="">Log Out</button></div>
             </div>
         </div>
         <img class="hamburguer" @click="mostrarmenu" src="/imgs/card.png" alt="">
     </header>
 </template>
 
 <script>
 export default {
   name: 'cabeça',
   props:["logo"],
   data(){
     return{
         logout: true,
         Nome: '',
         Email: '',
         mostrar_config: false,
         abrindo:{
            abrir2: false
         }
        
     }
     
   },
   computed:{
    logtr(){
        this.logadoOrN()
        return this.$store.state.user.id != null
    }
   },
   methods:{
     async logadoOrN(){
        if (this.$store.state.user.id != null){
            const user = await fetch(`https://localhost:7179/api/Usuario/${this.$store.state.user.id}`)
            const resp = await user.json()
            this.Nome = resp.nome
            this.Email = resp.email
            this.logout = false;
            this.logado=true
           
            
        }else{
            this.logout = false;
            this.logado=true
        }
     
     },
     logoutt(){
        this.$store.commit('setid', null),
        this.$store.commit('setToken', null),
        this.logout = true;
        
     },
     mostrar(){
        this.mostrar_config = !this.mostrar_config
     },
     mostrarmenu(){
        this.abrindo.abrir2 = true
     },
     fechando(){
        this.abrindo.abrir2 = false
     }
   }
 }
 </script>
 
 <!-- Add "scoped" attribute to limit CSS to this component only -->
 <style scoped>
        .fechar{
            width: 30px;
            display: none;
        }
        .logOut{
            background-color: rgb(183, 97, 223);
            border: none;
            cursor: pointer;
            font-weight: bolder;
            margin-left: 10px;
            padding-right: 5px;
            color: white;
            
            }
        .abrir2{
            width: 50%;
            transition: 0.5s;
        }
        .fechando{
            width: 0%;
        }
        .porta{
            width: 20px;
            margin-left: 10px;
            margin-right: 5px;
            
        }
        .em{
            margin-left: 10px;
            font-family: Arial, Helvetica, sans-serif;
            font-weight: bolder;
            margin-bottom: -2px;
            margin-top: 10px;
            cursor: default;
        }
        .em2{
            padding-left: 20px;
            width: 200px;
            color: white;
            font-family: Arial, Helvetica, sans-serif;
            font-weight: bolder;
            background-color: #4984FA;
            border: 2px solid #8B40DE;
            padding: 5px;
            cursor: default
        }
        .config{
            background-color: rgb(183, 97, 223);
            position: absolute;
            right: 40px;
            top: 70px;
            padding-bottom: 20px;
            color: white;
            z-index: 9999;
           
        }
        .perfil{
            background-color: rgb(183, 97, 223);
            width: 50px;
            height: 50px;
            display: flex;
            justify-content: center;
            align-items: center;
            border-radius: 50%;
            color: white;
            font-family: Arial, Helvetica, sans-serif;
            font-weight: bolder;
            position: absolute;
            bottom: 35px;
            right: 5px;
            
        }
        .username{
            margin-right: 10px;
            font-family: Arial, Helvetica, sans-serif;
            font-weight: bolder;
            color: white;
            position: absolute;
            right: 50px;
        }
        .usuario{
            display: flex;
            flex-direction: row;
            margin-top: 30px;
            margin-right: 40px;
            position: relative;
            cursor: pointer;
            

        }
         header{
            position: relative;
             display: flex;
             flex-direction: row;
            justify-content: space-between;
             width: 100%;
             background-color: #8B40DE;
             top: 0;
            
             
         }
         .button-login{
            background-color: transparent;
            color: white;
            font-family: Arial, Helvetica, sans-serif;
            font-weight: bolder;
            margin-top: 30px;
            border:none;
            cursor: pointer;  
            outline: 0;          
         }
         .hamburguer{
            position: absolute;
            width: 40px;
            right: 10px;
            top: 20px;
            display: none;
           
            
       }
         .button-cadastrar{
            padding: 5px;
            width: 120px;
            color: white;
            border: 2px solid #4984FA;
            cursor: pointer;
            background-color: transparent;
            border-radius: 5px;
            transition: 1s;
            outline: 0;
         }
         .button-cadastrar:hover{
            background-color: #4984fa8e;
         }
         .container-buttons{
            margin-right: 20px;
         }
        .router-link-active::after{
            content: " ";
             width: 100%;
             height: 3px;
             background-color: #4984FA;
             position: absolute;
             bottom:  0;
             left: 0;
             transition: 0.5s;
        }
       
         .logo{
             width: 100px;
             margin-left: 20px;
         }
         .lupa{
             width: 20px;
             position: absolute;
             right: 10px;
             top: 2px;
             cursor: pointer;
             
         }
         nav ul{
             list-style: none;
             display: flex;
         }
         nav a{
             color: white;
             text-decoration: none;
             margin-left: 20px;
             padding-bottom: 5px;
             font-family: Verdana, Geneva, Tahoma, sans-serif;
             transition: 1s;
             position: relative;
             
         } 
         nav a:hover::after{
             width: 100%;
         }
         nav a:hover{
             color:#666ede;
         }
        
         nav a::after{
             content: " ";
             width: 0%;
             height: 3px;
             background-color: #4984FA;
             position: absolute;
             bottom:  0;
             left: 0;
             transition: 0.5s;
         }
         nav{
             margin-top: 35px;
         }
         .pesquisa{
            margin-top: 30px; 
            margin-right: 20px;
            position: relative;
         }
         .peq{
             background-color: white;
             
         }
         .text{
             border-radius: 15px;
             border: none;
             height: 25px;
             padding-left: 15px;
             
             
         }
        .text::placeholder{
         font-family: Verdana, Geneva, Tahoma, sans-serif;
        }
        @media screen and (max-width: 2560px){
            ul li{
                font-size: 20px;
            }
            .text::placeholder{
            font-family: Verdana, Geneva, Tahoma, sans-serif;
            font-size: 20px;
            }
            
        
       }
       @media screen and (max-width: 1404px){
        ul li{
            font-size: 15px;
        }
        .text::placeholder{
            font-family: Verdana, Geneva, Tahoma, sans-serif;
            font-size: 15px;
            }
       }
       @media screen and (max-width:768px){
        .hamburguer{
            display: block;
        }
        nav ul{
            flex-direction: column;
            
            
        }
        nav ul a{
            margin-top: 50px;
            text-align: center;
            width: 80px;
            margin-bottom: 20px;
            margin-left: 120px;
            font-family: Arial, Helvetica, sans-serif;
            
           
        }
        nav ul li{
            font-size: 20px;
        }
        nav{
        background-color: #512188;
        position: fixed;
        top: 0;
        width:0%;
        height: 100vh;
        z-index: 100000;
        top: -35px;
        right: 0;
        overflow: hidden;
        transition: 0.5s;
        
        
       }
       .fechar{
        display: block;
        margin-top: 20px;
        margin-left: 20px;
       }
       .container-buttons{
        padding-right: 40px;
       }
       .usuario{
            margin-right: 60px;
        }
       }
       @media screen and (max-width:425px){
        nav ul li {
            font-size: 20px;
            
            width: 50px;
        }
        .usuario{
            margin-right: 60px;
        }
        nav ul a{
            margin-left: 40px;
        }
       }
       @media screen and (max-width: 375px) {
        nav ul a{
            margin-left: 25px;
        }
       }
       
 </style>