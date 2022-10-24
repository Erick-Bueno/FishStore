<template>
   
    <header>
         <img class="logo" src="imgs/peixe.png" alt="">
         <nav>
             <ul>
                 <router-link to="/">
                     <li>Home</li>
                 </router-link>
                 <router-link to="/Quem somos">
                     <li>Quem Somos</li>
                 </router-link>
                 <router-link to="/about">
                     <li>Peixes</li>
                 </router-link>
                 <router-link to="/contato">
                     <li>Contato</li>
                 </router-link>
             </ul>
         </nav>
         <div class="pesquisa">
             <input id="te" class="text" placeholder="Pesquisa" type="text"><img class="lupa" id="lupa" src="imgs/lupa.png" alt="">
         </div>
     </header>
 </template>
 
 <script>
 export default {
   name: 'cabeça',
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
             position: fixed;
             width: 100%;
             background-color: #8B40DE;
             top: 0;
             
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
 </style>