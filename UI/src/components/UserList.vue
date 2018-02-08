<template>
  <div class="row">

    <div class="col-xs-12 col-sm-8 col-sm-offset-2 col-md-6 col-md-offset-3">
      <h1 style="text-align: left">User List</h1>
      <br><br>
      <div class="panel panel-default">
        <!-- Default panel contents -->
        <div class="panel-heading">System Users</div>

        <!-- Table -->
        <table class="table">
          <thead>
          <tr>
            <th>#</th>
            <th>First Name</th>
            <th>Last Name</th>
            <th>Email</th>
            <th>User Name</th>
          </tr>
          </thead>
          <tbody>
          <tr v-for="u in users">
            <td>{{ u.id }}</td>
            <td>{{ u.firstname }}</td>
            <td>{{ u.lastname }}</td>
            <td>{{ u.email }}</td>
            <td>{{ u.username }}</td>
          </tr>
          </tbody>
        </table>
      </div>
    </div>
  </div>
</template>
<script>

  export default {
    data () {
      return {
        users: []
      }
    },
    methods: {
      fetchSystemUser () {
        this.$http.get('api/SystemUsers')
          .then((response) => {
            return response.json()
          }).then(data => {
          console.log(data)
          const resultArray = []

          for (let key in data) {
            resultArray.push(data[key])
          }
          this.users = resultArray
        })
      }
    },
    created () {
      this.fetchSystemUser()
    }
  }

</script>
<style scoped>

</style>
