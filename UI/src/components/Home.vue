<template>
  <div class="container" id="home">
    <div class="row">
      <div class="col-xs-12 col-sm-8 col-sm-offset-2 col-md-6 col-md-offset-3" style="align-content: center">
        <img style="width: 500px; height: 250px" src="./../assets/logo.png">
        <h1>Azure Micro Services</h1>
        <br><br>
        <button class="btn btn-primary btn-block" @click="navigateToUserView">Admin Service</button>
        <button class="btn btn-primary btn-block" @click="navigateToUserView">Document Import Service</button>
      </div>
    </div>
  </div>
</template>

<script>
export default {
  methods: {
    navigateToUserView() {
      this.$router.push({name: 'UserList'});
    }
  }
}
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
  #home {
    -webkit-font-smoothing: antialiased;
    -moz-osx-font-smoothing: grayscale;
    text-align: center;
    color: #2c3e50;
    margin-top: 60px;
  }
</style>
