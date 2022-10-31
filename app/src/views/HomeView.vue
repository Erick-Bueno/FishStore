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
        
    </main>
    <section class="content">
        <aside>
            <h1 class="cat">Categorias</h1>
        </aside>
        <article id="peixada">
            <div class="borda"></div>
            <h1 class="dest">Destaques</h1>
            <section class="peixess">
                
                <div v-for=" peixe in lista_peixes" class="teste  ">
                    <img :src="peixe.imagem" class="imagens" alt=""> <br>
                    {{peixe.nomePeixe}}
                    
                </div>
                
                <img src="" alt="">
            </section>
        </article>
    </section>
</template>
<style>
       
        main{
        padding-top: 20px;
        background-image: linear-gradient(to right,#7453F5,#404BDE);
        padding-bottom: 20px;
        
       }
      .slider{
        margin: 0px auto;
        width: 1000px;
        height: 500px;
        border-radius: 20px;
        overflow: hidden;
        margin-top: 20px;
        
        
        
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
        bottom: -6px;
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
        margin: auto;
        
       }
       .dest{
        
        text-align: center;
        right: 450px;
        padding-top: 65px;
        padding-bottom: 20px;
        font-family: Verdana, Geneva, Tahoma, sans-serif;
        font-size: 34px;
        
       }
       .cat{
        margin-left: 50px;
        padding-top: 40px;
        font-family: Verdana, Geneva, Tahoma, sans-serif;
        font-size: 20px;
       }
       .borda{
        border: 1px solid black;
        position: absolute;
        margin-top: 50px;
        width: 70%;
        margin-left: 120px;
       }
       .peixess{
        width: 90%;
        margin-left: 150px;
        display: flex;
        justify-content: space-between;
        flex-wrap: wrap;
        text-align: center;
       }
       .imagens{
        width: 80%;
        height: 80%;
       }
       .teste{
        background-color: red;
        width: 250px;
        height: 180px;
        margin: 30px;
        text-align: center;
        font-family: 'Courier New', Courier, monospace;
        font-weight: bold;
        
       }
       #peixada{
        width: 80%;
        
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
                console.log(dados)
            }
            
                    
                 
            }
        }      
        
     
   
    
    
</script>
