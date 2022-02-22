<template>
  <div class="hello">
    <h1>'Nexify Limited Test Project'</h1>
    <table class="table">
      <caption>
        <button @click="AddNewItem">Add</button>
        <button>Save</button>
        <button>Refresh</button>
      </caption>
      <thead>
          <tr>
              <th>Name</th>
              <th>Birth Day</th>
              <th>Salary</th>
              <th>Address</th>
          </tr>
      </thead>
      <tbody>
          <tr v-for="item in editEmploymentInformationData" :key="item.id">
              <td><input type="text" v-model="item.name" /></td>
              <td><datepicker v-model="item.birthday" format="yyyy/MM/dd"></datepicker></td>
              <td><input type="range" v-model="item.salary" min="0" max="100000" step="500" /><label>{{item.salary}}</label></td>
              <td><input type="text" v-model="item.address" /></td>
          </tr>
      </tbody>
  </table>
  </div>
</template>

<script>
  import Datepicker from 'vuejs-datepicker';
  export default {
    name: 'Employment-Information',
    props: {
      employmentInformationData: []
    },
    components: {
      Datepicker
    },
    data() {
      return{
        editEmploymentInformationData: [],
      }
    },
    methods:{
      AddNewItem(){
        this.editEmploymentInformationData.push({
          id: this.editEmploymentInformationData.length + 1,
          name: '',
          birthday: '',
          salary: 0,
          address: '',
        });
      }
    },
    mounted (){
      
      this.editEmploymentInformationData = this.employmentInformationData;
    }
  }
</script>

<style scoped>
  table { width:100%; }
  td { text-align:left; }
  button { margin-right: 10px;}
  .icon{
    background-image: url('https://image.shutterstock.com/image-vector/mobile-phone-icon-smartphone-cell-260nw-1695955351.jpg');
    background-position: 0 0; width: 32px; height: 32px;
    display: inline-block;
  }
</style>
