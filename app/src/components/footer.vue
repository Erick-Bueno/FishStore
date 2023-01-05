<template>
   
       <footer>
            <img class="logo" :src="logo" alt="">
            <p class="site">Site Produzido Por Erick Bueno <br> utilizando as tecnologias vue.js e c#</p>
            <ul class="linka">
                <li class="tit">Links</li>
                <div class="borda"></div>
                <div class="borda2"></div>
       
                <li class="item">Home</li>
                <li class="item">Quem Somos</li>
                <li class="item">Peixes</li>
                <li class="item">Contato</li>
            </ul>
            <div class="likss">
                <div class="linkedin forma"> <img :src="logo_linke" alt="" class="linked"></div>
                <div class="github forma"> <img :src="logo_git" alt="" class="git"></div>
                <div class="twitter forma"> <img :src="logo_twitter" alt="" class="twi"></div>
            </div>
            <div class="borda3"></div>
           <P class="direitos"> FishStore &copy 2022 Direitos Reservados</P>
       </footer>
  
</template>

<script>
    export default{
        name: "rodape",
        props:["logo","logo_linke","logo_git","logo_twitter"]
    }
</script>
<style scoped>

   

    footer{
        width: 100%;
        background-color: #8B40DE;
        position: absolute;
        
       
      
        
        
    }
    .direitos{
        font-family: 'Courier New', Courier, monospace;
        font-weight: bolder;
        color: white;
        text-align: center;
        margin-top: 100px;
       
        
    }
    .logo{
        width: 100px;
        margin-left: 80px;
        margin-top: 20px;
        
    }
    ul{
        list-style: none;
        font-family: 'Courier New', Courier, monospace;
        position: absolute;
        right: 550px;
        bottom: 90px;
      

      
    }
    .site{
        font-family: 'Courier New', Courier, monospace;
        font-weight: bold;
        color: white;
        margin-left: 75px;
        
    }
    .tit{
        color: white;
        margin-bottom: 15px;
        font-weight: bolder;
        cursor: default;
        transition: 1s;
        font-family: 'Courier New', Courier, monospace;
        
    }
    .borda{
        width: 60px;
        border: 2px solid rgba(255, 255, 255, 0.97);
        border-radius: 2px;
        position: absolute;
        right: 45px;
        bottom: 130px;
       
    }
    .borda2{
        width: 0px;
        border: 2px solid rgba(156, 150, 150, 0.97);
        border-radius: 2px;
       
        position: absolute;
        right: 45px;
        bottom: 130px;
       
        transition: 0.5s;
    }
    .tit:hover ~ .borda2{
       width: 60px;
       
    }
    
    .item{
        color: white;
        cursor: pointer;
        transition: 1s;
        padding-bottom: 5px;
    }
    .item:hover{
        color:#490a91;
    }
    .borda3{
        width:90%;
        border: 2px solid rgba(156, 150, 150, 0.97);
        position: absolute;
        bottom: 50px;
        margin-left: 60px;
    }
    .forma{
        background-color: #b47af5;
        width: 40px;
        height: 40px;
        border-radius:50%;
        position: absolute;
        bottom: 200px;
        cursor: pointer;
       
        
        }
    .twitter{
        right: 60px;
        transition: 0.5s;
        border: 2px solid black;
    }
    .github{
        right: 105px;
        transition: 0.5s;
    }
    .linkedin{
        right: 150px;
        transition: 0.5s;
    }
    .linked{
        width: 40px;
        position: absolute;
        
        
    }
    .forma:hover{
        background-color: rgb(166, 0, 255);
    }
    .git{
        width: 40px;
        position: absolute;
    }
    .twi{
        width: 27px;
        position: absolute;
        top: 6px;
        left: 7px;
    }
    @media screen and (max-width: 2560px){
        .direitos{
            margin-top: 200px;
            font-size: 22px;
            
        }
        .site{
            font-size: 22px;
            margin-left: 140px;
        }
        .borda3{
            margin-left: 80px;
        }
        .logo{
            width: 200px;
            margin-left: 140px;
        }
        .linka{
            margin-bottom: 120px;
            margin-right: 500px;
        }
        .tit{
            font-size: 25px;
            margin-right: -20px;
            
        }
        .borda{
            width: 100px;
            right: 60px;
            bottom: 190px;
        }
        .borda2{
            right: 60px;
            bottom: 190px;
        }
        .item{
            font-size: 25px;
        }
       
    }
    
    @media screen and (max-width: 2104px){
        .linka{
            margin-right: 300px;
        }
    }
    @media screen and (max-width: 1780px){
        .linka{
            margin-right: 170px;
        }
    }
    @media screen and (max-width: 1564px){
        .linka{
            margin-right: 60px;
        }
    }
    @media screen and (max-width: 1404px){
        .linka{
            margin-right: -70px;
        }
    }
    @media screen and (max-width: 1325px){
        .logo{
            width: 100px;
        }
        .linka{
            margin-bottom: 40px;
        }
        .tit{
            font-size: 15px;
        }
        .item{
            font-size: 15px;
            
        }
        .direitos{
            
            font-size: 15px;
        }
        .site{
            font-size: 15px;
        }
        .borda{
            width: 60px;
            top: 20px;
            right: 40px;
        }
        .borda2{
            top: 20px;
            right: 40px;
        }
    }
    
    @media screen and (max-width:768px){
        .linka{
            margin-bottom: -30px;
        }
        .borda3{
            width: 85%;
        }
    }
    @media screen and (max-width:425px){
        .borda3{
            display: none;
        }
        .logo{
            margin-left: 10px;
        }
        .site{
            margin-left: 20px;
            padding-bottom: 30px;
            
        }
        .forma{
            margin-right: 60px;
            bottom: 130px;
        }
      
       
    }
  
</style>