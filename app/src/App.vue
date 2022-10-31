<template>
  <cabeça :logo="link_logo" />
  <router-view class="cont" :peixe1="img_peixe1" :peixe2="img_peixe2" :peixe3="img_peixe3" />
  <rodape :logo="link_logo" :logo_linke="linkedin" :logo_git="github" :logo_twitter="twiter"></rodape>
 

  
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
        twiter:"imgs/twitter.png"
        
      }
      
    },
    
    
    
  }
</script>
<style>
  *{
    padding: 0;
    margin: 0;
  }

  

  
</style>

