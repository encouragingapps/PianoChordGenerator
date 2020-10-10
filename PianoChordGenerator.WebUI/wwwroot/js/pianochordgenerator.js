var app = new Vue({
    el: '#app',
    mounted: function () {
        alert('this loaded!');
    },
    data: {
        Test: '',
        Test2: ''
    },
    methods: {
        getChords: function (event) {
            axios.get('/Index/GetChordData')
                .then((response) => {
                    console.log(response.data);
                    console.log(response.status);
                    console.log(response.statusText);
                    console.log(response.headers);
                    console.log(response.config);
                }).catch(function (error) {
                    console.log(error);
                });           
        }
    }
})