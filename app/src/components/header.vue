<template>
   
    <header>
         <img class="logo" :src="logo" alt="">
         <nav>
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
         <div class="container-buttons">
            <button @click="$router.push('/login')" class="button-login">Login</button> <button @click="$router.push('/cadastro')" class="button-cadastrar">Cadastrar</button>
         </div>
     </header>
 </template>
 
 <script>
 export default {
   name: 'cabeça',
   props:["logo"],
   data(){
     return{
         
     }
     
   }
 }
 </script>
 
 <!-- Add "scoped" attribute to limit CSS to this component only -->
 <style scoped>
    
         header{
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
 </style>