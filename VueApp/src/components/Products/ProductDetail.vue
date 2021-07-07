<template>
  <section>
      <h2>Product Details</h2>
        <ul v-if="product && product.description">
            <li>Product: {{ product.title }}</li>
            <li>Price: {{ product.price }}</li>
            <li>Category: {{ product.category }}</li>
            <li>Description: {{ product.description }}</li>
            <li><router-link :to="`/products/`"> Back to products</router-link></li>
            <img :src="product.image" width=250>
        </ul>
      <p>{{ message }}</p>
  </section>
</template>

<script>
import axios from 'axios'
export default {
    name: 'ProductDetail',
    created() {
        // get product detail 
        console.log(this.$route.params.id)
        this.getProductDetail(this.$route.params.id)
    },
    data: () => ({
        product: {},
        message: ''
    }),
    methods: {
        getProductDetail(id) {
            axios.get(`https://localhost:5001/api/WebshopItems/${id}`).then(result => {
                console.log('details', result.data);
                this.product = result.data
            }).catch(() => {
                this.message = 'Did not find a product with this id'
            })
        }
    }
}
</script>

<style>
li{
    text-align: left;
}
</style>