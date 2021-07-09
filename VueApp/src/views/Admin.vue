<template>
  <section>
      <h1>Cart</h1>
      <div id="admin">
        <product-create />
      </div>
  </section>
</template>

<script>
//import ProductCreate from '../components/Products/ProductCreate.vue'
import ProductCreate from "../components/Products/ProductCreate.vue"
export default {
    name: 'Admin',  
    components: { ProductCreate }
}
</script>

<style>
  #prodlist{
    text-align: left;
  }
</style>