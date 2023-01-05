<template>

<div class="general-container">
  <div class="top-container">
    <div v-show="registerAndLoginPage">
      <cabeça :logo="link_logo" />
    </div>
  
    <div>
      <router-view  :peixe1="img_peixe1" :peixe2="img_peixe2" :peixe3="img_peixe3" />
    </div>
  </div>
  
  <div>
    <rodape v-show="registerAndLoginPage" :logo="link_logo" :logo_linke="linkedin" :logo_git="github" :logo_twitter="twiter"></rodape>
  </div>
</div>

      
 
  
   
      
 
  

      


      
   
  
 
      
 
  
  
    
 
    
   
    

 

  
</template>
<script>
  import cabeça from './components/header.vue'
  import rodape from './components/footer.vue'
  
  
 
  
 
  export default{
    components:{
      cabeça,
      rodape,
      
     
      
    },
    
    
    
    data(){
      return{
        link_logo: "/imgs/peixe.png",
        img_peixe1: "/imgs/peixe.webp",
        img_peixe2:"/imgs/puffer-fish-fish-the-aquazoo-dusseldorf-aquarium.jpg",
        img_peixe3:"imgs/18dc6970-ad4a-49ab-beb5-5022a5242be3-1023x576.webp",
        linkedin:"imgs/linkedin (2).png",
        github:"imgs/github (1).png",
        twiter:"imgs/twitter.png",
        exibir: true
        
      }
      
    },
   computed:{
    registerAndLoginPage(){
      //se as rotas n forem de login e nem cadastro entao o footer e o header serao mostrados
      //o computed é executado de acordo com as alterações q as variaveis sofrem
        return this.$route.name !== 'cadastro' && this.$route.name !== 'login'
        
      }
   },
    methods:{
  
    }
  }
      
    
    
    
    
  
</script>
<style>
  *{
    padding: 0;
    margin: 0;
   
  }
  body{
    background-image: linear-gradient(to right,#7453F5,#404BDE);
  }
  .general-container {
  min-height: 100vh;
  display: flex;
  flex-direction: column;
}

.top-container {
  flex: 1;
}




  
</style>

