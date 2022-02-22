<template>
  <div id="app">
    <img alt="logo" src="data:image/png;base64,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">
    <EmploymentInformation 
      :employment-information-data=EmploymentInformationData 
      @upsert="UpsertData"
      @refresh="RefreshData"
    />
  </div>
</template>

<script>
import EmploymentInformation from './components/Employment-Information.vue'

export default {
  name: 'App',
  components: {
    EmploymentInformation
  },
  data(){
    return{
        EmploymentInformationData: [],
    }
  },
  methods:{
    async UpsertData(requsetData){
      const requestOptions = {
        method: "POST",
        headers: { 
          "Content-Type": "application/json", 
          "Access-Control-Allow-Origin": '*', 
        },
        body: requsetData
      };
      const response = await fetch("https://localhost:44390/api/Employment", requestOptions);
      const data = await response.json();
      if(data == true) 
        alert('Save Success!!');
    },
    async RefreshData(){
      const requestOptions = {
        method: "GET",
        headers: { 
          "Content-Type": "application/json",
          "Access-Control-Allow-Origin": '*',
        },
      };

      const response = await fetch('https://localhost:44390/api/Employment', requestOptions);
      const data = await response.json();
      this.EmploymentInformationData = data;
    },
  },
  mounted(){
    this.RefreshData();
  }
}
</script>

<style>
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
  margin-top: 60px;
}
</style>
