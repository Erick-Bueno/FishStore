<template>
      
          
              <main>
                <!--slider-->
                <div class="slider">
                    <div class="imgs">
                        <!--primeiro radio butons-->
                        <!--v-model="valores" checkando valores relacionados ao value-->
                        <input  type="radio" name="radio" class="btn-radio"  value="1" id="radio1" v-model="valores">
                        <input type="radio" name="radio" class="btn-radio" value="2" id="radio2" v-model="valores">
                        <input type="radio" name="radio" class="btn-radio" value="3" id="radio3" v-model="valores">
                         <!--segundo imagens-->
                         <div class="slide primeiro">
                            <img :src="peixe1" alt="peixe Exotico">
                         </div>
                         <div class="slide">
                            <img :src="peixe2" alt="peixe Exotico 2">
                         </div>
                         <div class="slide">
                            <img :src="peixe3" alt="peixe Exotico 3">
                         </div>
              
                         <!-- terceiro deixar as labels marcadas-->
                         <div class="navegacao">
                            <div class="nav-btn1"></div>
                            <div class="nav-btn2"></div>
                            <div class="nav-btn3"></div>
                    </div>
              
                    </div>
                    <!--quarto labels-->
                    <div class="navegacao-labels">
                        <label for="radio1" class="label-nav"></label>
                        <label for="radio2" class="label-nav"></label>
                        <label for="radio3" class="label-nav"></label>
                    </div>
                </div>
                <section class="content">
                <article id="peixada">
                    <div class="borda"></div>
                    <h1 class="dest">Destaques</h1>
                    <section class="peixess">
              
                        <div v-for=" peixe in lista_peixes" class="teste  ">
                            <img :src="peixe.imagem" class="imagens" alt=""> <br>
                            <span class="nomepeixe">{{peixe.nomePeixe}}</span> <br>
                            <router-link :to="{name:'peixess', params:{id:peixe.id}}">
                                <button @click="rolarPraCima" class="veja">Veja Mais</button>
                            </router-link>
                        </div>
              
                        <img src="" alt="">
                    </section>
                </article>
                  </section>
          
              
    </main>
       
   
</template>
<style scoped>
        @import url('https://fonts.googleapis.com/css2?family=Josefin+Sans&display=swap');
       
        main{
        padding-top: 20px;
        background-image: linear-gradient(to right,#7453F5,#404BDE);
        padding-bottom: 10px;
        margin-bottom: -10px;
        min-height: 100vh;
        
       }
      .slider{
        margin: 0px auto;
        width: 1000px;
        height: 500px;
        border-radius: 20px;
        overflow: hidden;
        margin-top: 20px;
        
        
        
       }

       .nomepeixe{
        font-family: 'Josefin Sans', sans-serif;
        color: white;
        font-size: 20px;
       }
       .veja{
        background-color:#7453F5 ;
        color:#c0c0c9 ;
        padding: 5px;
        border-radius: 5px;
        transition: 0.5s;
        font-weight: bolder;
        font-family: 'Josefin Sans', sans-serif;
        border: 3px solid white;
        
       
       }
       .veja:hover{
        background-color:#e7e6eb;
        color: black;
        cursor: pointer;
       }
     
       .peixi li{
        padding-left: 150px;
       }
       
      
       .imgs{
        width: 300%;
        height: 100%;
        display: flex;
       }
       .imgs input{
        display: none;
       }
       .slide{
        width: 33.33333%;
        transition: 1s;
       }
       .slide img{
        width: 1000px;
       }
       .navegacao-labels{
        position: absolute;
        width: 1000px;
        margin-top: -50px;
        display: flex;
        justify-content: center;
       }
       .label-nav{
        border: 2px solid #8B40DE;
        padding: 15px;
        border-radius: 50%;
        cursor: pointer;
        transition: 1s;
        margin: 5px;

       }
       .label-nav:hover{
        background-color:#8B40DE;
       }
       #radio1:checked ~ .primeiro{
        margin-left: 0;
       }
       #radio2:checked ~ .primeiro{
        margin-left: -33.33333333333%;
       }
       #radio3:checked ~ .primeiro{
        margin-left: -66.666666%;
       }
       .navegacao div{
        border: 2px solid #8B40DE;
        padding: 15px;
        border-radius: 50%;
        margin: 5px;
        cursor: pointer;
        transition: 1s;
       }
       .navegacao{
        
        position: absolute;
        width: 1000px;
        
        display: flex;
        justify-content: center;
       }
       #radio1:checked ~ .navegacao .nav-btn1{
        background-color:#8B40DE;
       }
       #radio2:checked ~ .navegacao .nav-btn2{
        background-color: #8B40DE;
       }
       #radio3:checked ~ .navegacao .nav-btn3{
        background-color: #8B40DE;
       }
       .content{
        display: flex;
        position: relative;
        justify-content: center;
        align-items: center;
      
        background-image: linear-gradient(to right,#7453F5,#404BDE);
        padding-bottom: 60px;
        margin-bottom: -40px;
        
       }
       .dest{
        
        text-align: center;
        right: 450px;
        
        padding-top: 65px;
        padding-bottom: 20px;
        font-family: 'Josefin Sans', sans-serif;
        font-size: 40px;
        font-weight: bolder;
        color: white;
        
       }
       .cat{
        margin-left: 50px;
        padding-top: 40px;
        font-family: Verdana, Geneva, Tahoma, sans-serif;
        font-size: 20px;
       }
       .borda{
       
       
        border-radius: 4px;
        border: 3px solid white;
        margin-top: 50px;
        width: 100%;
      
       }
       .peixess{
        width: 100%;
        display: flex;
        flex-wrap: wrap;
        justify-content: left;
      
        
        
       }
       .imagens{
        width: 80%;
        height: 80%;
       }
       .teste{
        width: 250px;
        height: 180px;
        margin: 30px;
        padding-top: 15px;
        text-align: center;
        font-family: 'Courier New', Courier, monospace;
        font-weight: bold;
        border: 3PX solid white;
        border-radius: 15px;
        
       }
       @media screen and (max-width: 2560px){
        .navegacao{
            bottom: 267px;
        }
       }
       @media screen and (max-width: 1920px){
        .navegacao{
            bottom: 447px;
        }
       }
       @media screen and (max-width: 1848px){
        .peixess{
            padding-left: 140px;
        }
        .borda{
            width: 80%;
            margin: auto;
            margin-top: 20px;
        }
        .navegacao{
            bottom: 268px;
        }
     
       }
       @media screen and (max-width: 1664px){
        .peixess{
            padding-left: 170px;
        }
       }
       
       @media screen and (max-width: 1511px){
        .navegacao{
            bottom: 0px;
        }
       }
       @media screen and (max-width: 1440px){
        .peixess{
            padding-left: 100px;
        }
        .navegacao{
            bottom: 0px;
        }
       }
       @media screen and (max-width: 1404px){
        .peixess{
            padding-left: 105px;
        }
       }
       @media screen and (max-width: 1366px){
        .navegacao{
            bottom: 134px;
        }
       }
       @media screen and (max-width: 1344px){
        .peixess{
            padding-left: 175px;
        }
    }
    @media screen and (max-width: 1325px){
        .navegacao{
            bottom: -6px;
        }
        .peixess{
            padding-left: 195px;
        }
        
    }
      

</style>
<script>
    
    export default{
        name: "home",
        data(){
            return {
               lista_peixes: [],
               valores:1
               
               
            }
        
           
        },
        props:["peixe1", "peixe2", "peixe3"],
    
        mounted(){
           
            this.pegar_dados()
            this.passar_slider()
    },
        methods:{
            passar_slider(){
                this.valores = 1
            setInterval(() => {
                
                //alterando os valores checados para ir passando as imagens
                
                   
                
                        
                        this.valores = this.valores + 1
                        if(this.valores > 3){
                            this.valores = 1
                        
                    }
                    
                
            }, 4000);
        },
            async pegar_dados(){
                const resp = await fetch('https://localhost:7179/api/Peixe')
                const dados = await resp.json()
                
                this.lista_peixes = dados
               
                
            },
            rolarPraCima(){
                window.scrollTo(0,0)
            }
            
                    
                 
            }
        }      
        
     
   
    
    
</script>
