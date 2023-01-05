<template>
        <div class="loader-container">
            <img class="load" src="/imgs/loader2.svg" alt="">
        </div>
</template>

<script>
export default{
    name: 'loader',
    data(){
        return{

        }

    }
}
</script>

<style scoped>
.loader-contaier{
    width: 100%;
    height: 100%;
    display: flex;
    justify-content: center;
    align-items: center;
    position: relative;
   
}
.load{
    width: 150px;
    position: absolute;
    margin-left: 50px;
    top: 108px;
    width: 100px;
    position: absolute;
    z-index: 999;
    text-align: center;
}
@media screen and (min-width: 1920px){
    .load{
        top: 200px;
    }
}
@media screen and (max-width: 768px){
    .load{
        top: 250px;
    }
}
@media screen and (max-width: 375px) {
    .load{
        left: 80px;
    }
}
</style>