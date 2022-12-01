<template>
    <p>{{mensagem}}</p>
</template>

<script>
    export default{
        name:"mensagem",
        props:['mensagem']
            
        
    }
</script>

<style scoped>
    p{
        font-family: Verdana, Geneva, Tahoma, sans-serif;
        font-weight: bolder;
        font-size: 15px;
        background-color: #431ae7;
        color: white;
        border: 2px solid black;
        margin-top: 50px;
        margin-bottom: -50px;
        width: 400px;
        padding: 5px;
        text-align: center;
        margin-bottom: -30px;
       
    }
</style>