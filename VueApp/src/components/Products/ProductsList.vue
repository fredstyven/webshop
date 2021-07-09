<template>
  <div>
        <ul>
            <li v-for="(product, index) in products" :key="title + index">
                <span>ID: {{ product.id }} - </span>
                <span>{{ product.title }}</span>
                <span> - Price: {{ product.price }}</span>
                <button @click="removeFromCart()" v-if="isInCart()">remove from cart</button>
                <button @click="addToCart(product)" v-else>add to cart</button>
                <button @click="$router.push('/admin')">check out</button>
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
        products: [],
        cart: []
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
        },
        isInCart() {
            //return this.cart.some(prod => prod.id === item.id);
            //return this.cart.includes(item);
                /*console.log("TRUE");
            return true;
            }
            else {return false;}*/
            //return Boolean(cartItem);
            //return false;
        },
        addToCart(item) {
            let copyItem = JSON.parse(JSON.stringify(item));
            if(!(this.cart.some(product => product.id === copyItem.id))) {
                //let copyItem = JSON.parse(JSON.stringify(item));
                this.cart.push(copyItem);

            }
            this.cart.forEach((x) => console.log(x));
        
        },
        removeFromCart() {
            /*let copyItem = JSON.parse(JSON.stringify(item));
            this.cart.splice(copyItem, 1);*/
        },
    }
}
</script>

<style>
</style>