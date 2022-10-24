<template>
      <main>
        <!--slider-->
        <div class="slider">
            <div class="imgs">
                <!--primeiro radio butons-->
                <input type="radio" name="radio" class="btn-radio" id="radio1">
                <input type="radio" name="radio" class="btn-radio" id="radio2">
                <input type="radio" name="radio" class="btn-radio" id="radio3">
                 <!--segundo imagens-->

                 <div class="slide primeiro">
                    <img src="/imgs/peixe.webp" alt="peixe Exotico">
                 </div>

                 <div class="slide">
                    <img src="imgs/puffer-fish-fish-the-aquazoo-dusseldorf-aquarium.jpg" alt="peixe Exotico 2">
                 </div>

                 <div class="slide">
                    <img src="imgs/18dc6970-ad4a-49ab-beb5-5022a5242be3-1023x576.webp" alt="peixe Exotico 3">
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
</template>
<style>
       
        main{
        padding-top: 100px;
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
        bottom: 13px;
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
        
       }
</style>
<script>
    export default{
        methods:{
            passar_slider(){
                let count = 1
            document.getElementById("radio1").checked = true;

            setInterval(function(){
                proximaimg()
            }, 2000)
            function proximaimg(){
                count = count + 1
                if(count > 3){
                    count = 1
                }
                document.getElementById("radio" + count).checked = true;
            }
        }
        },
        mounted(){
            this.passar_slider()
        }
    }
</script>
