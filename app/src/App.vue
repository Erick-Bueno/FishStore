<template>
  <cabeça/>
  <router-view class="cont" />
  <rodape class="fut"></rodape>
  
</template>
<script>
  import cabeça from './components/header.vue'
  import rodape from './components/footer.vue'
  export default{
    components:{
      cabeça,
      rodape
    }
  }
</script>
<style>
  *{
    padding: 0;
    margin: 0;
  }
  .cont{
    padding-top: 100px;
  }
  .fut{
    position: absolute;
    bottom: 0px;
  }
  
</style>

