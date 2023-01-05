<template>
  
    
            <section v-show="existe" class="container0">
                <section class="container1">
                    {{Nome_peixe}}
                    <img class="imagiii" :src="img" alt="">
                </section >
                <section class="container2">
                    <h1 class="descri">Descrição</h1>
                    <p class="desc">Lorem, ipsum dolor sit amet consectetur adipisicing elit. Eos tempora voluptatem non magnam facilis commodi et inventore ratione, culpa praesentium provident perspiciatis maiores, labore tempore ullam ducimus necessitatibus, corporis nulla. Lorem ipsum dolor sit amet consectetur adipisicing elit. Quis ipsa, officiis dolor eos vitae molestiae impedit quae? Excepturi aperiam fugit quae! Officia ipsum nemo nisi itaque exercitationem consectetur iure veniam!</p>
                </section>
            </section>
       
        
        
            
            <formPeixe></formPeixe>

        
        
           
  

 
  
   
 
</template>
<script>
import formPeixe from '../components/FormPeixe.vue'
import mensagem from '../components/mensagem.vue'
    export default{
        name: 'peixes',
        components:{
            mensagem,
            formPeixe
        },
        data(){
            return{
               Nome_peixe: null,
               descricao_peixe: null,
               img: null,
               existe: false
               
            }
        },
        mounted(){
            this.peixee()
        },
        methods:{
            async peixee(){
              const id = this.$route.params.id
              if(id != undefined){
              const dado = await fetch(`https://localhost:7179/api/Peixe/${id}`)
              const resp = await dado.json()
              this.existe = true
              this.Nome_peixe = resp.nomePeixe
              this.descricao_peixe = resp.descricao
              this.img = resp.imagem
              }
              else{
                this.existe = false
                console.log("aaaa")
              }
              
              
                
            }
        }
       
           
    }
</script>
<style scoped>
    .container1{
    display: flex;
    flex-direction: column;
    text-align: center;
    color: white;
    font-weight: bolder;
    font-size: 20px;
    font-family: 'Courier New', Courier, monospace;
    
    
}
.desc{
    color: white;
    font-family: 'Courier New', Courier, monospace;
    font-size: 16px;
}
    .imagiii{
        width: 400px;
        
        
}
.container0{
    display: flex;
    padding-top: 40px;
    justify-content: center;
    background-image: linear-gradient(to left, #431ae7, #7453F5);
    padding-bottom: 100px;
    border-bottom: 2px solid #180172;
   
    
}
.container2{
    margin-left: 150px;
    width: 400px;
    margin-top: 50px;
}
h1{
    font-family: 'Courier New', Courier, monospace;
    font-weight: bolder;
    color: white;
}
@media screen and (max-width: 425px) {
        .imagiii{
            width: 60%;
            margin-left: 75px;
           
        }
        .container0{
            flex-direction: column;
        }
        .container2{
            margin-left:10px;
            
        }
}
@media screen and (max-width: 375px){
    .descri{
        text-align: center;
    }
    .desc{
       
    }
    .container2
    {
        text-align: center;
        width: 350px;
    }
}
</style>