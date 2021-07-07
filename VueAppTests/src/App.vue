<template>
  <div id="app">
    <img alt="Vue logo" src="./assets/logo.png">
    <WebshopTest msg="Webshop Tests"/>
  </div>
</template>

<script>
import WebshopTest from './components/WebshopTest.vue'

export default {
  name: 'App',
  components: {
    WebshopTest
  }
}
</script>

<style>
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
  margin-top: 60px;
}
</style>
