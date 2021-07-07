<template>
  <div class="hello">
    <h1>{{ msg }}</h1>
    <ul><hr>
      <li align="left" v-for="(webshopItem,index) of webshopItems" :key="index+webshopItem.title">Id: {{webshopItem.id}},<br>Title: {{webshopItem.title}},<br>Price: {{webshopItem.price}},<br>Description: {{webshopItem.description}},<br>Category: {{webshopItem.category}}, <br>Image: {{webshopItem.image}}<hr></li>
    </ul>
  </div>
</template>

<script>
export default {
  name: 'WebshopTest',
  props: {
    msg: String,
  },
  data: () => ({
    webshopItems: []
  }),
  created() {
    this.loadUsers()
  },
  methods: {
    async loadUsers() {
      let response = await fetch("https://localhost:5001/api/WebshopItems")
      let data = await response.json();
      console.log(data);
      this.webshopItems = data
    }
  }
}
</script>

<style scoped>
h3 {
  margin: 40px 0 0;
}
ul {
  list-style-type: none;
  padding: 0;
}
li {
  margin: 0 10px;
}
a {
  color: #42b983;
}
</style>
