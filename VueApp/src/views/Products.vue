<template>
  <section>
      <h1>Products</h1>
      <div id="prodlist">
        <products-list />
      </div>
  </section>
</template>

<script>
import ProductsList from "../components/Products/ProductsList.vue"
export default {
  components: { ProductsList }
}
</script>

<style>
  #prodlist{
    text-align: left;
  }
</style>