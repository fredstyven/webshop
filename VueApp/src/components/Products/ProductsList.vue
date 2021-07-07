<template>
  <div>
        <ul>
            <li v-for="(product, index) in products" :key="title + index">
                <span>{{ product.title }}</span>
                <span> - Price: {{ product.price }}</span>
                <router-link :to="`/products/${product.id}`"> Show details</router-link>
            </li>
        </ul>

        <slot></slot>
  </div>
</template>

<script>
import axios from 'axios'
export default {
    name: 'ProductsList',
    created() {
        this.getProducts()
    },
    data: () => ({
        products: []
    }),
    methods: {
        getProducts() {
            axios.get('https://localhost:5001/api/WebshopItems')
                .then(result => {
                    console.log('results', result)
                    this.products = result.data
                }).catch(error => {
                    console.log('error', error)
                })
        }
    }
}
</script>

<style>
</style>