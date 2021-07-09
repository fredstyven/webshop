<template>
  <div>
    
  </div>
</template>

<script>
import axios from 'axios'
export default {
    name: 'ProductCreate',
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
    #form1{
        text-align: center
    }
</style>