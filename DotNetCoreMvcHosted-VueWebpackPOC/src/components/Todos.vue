<template>
  <div class="container">
    <div class="row">
      <div class="list-group">
        <h2>Todos</h2>
        <span v-if="isLoading">
          Loading results...
        </span>
        <a v-else
           v-for="(todo, i) in todos"
           v-bind:key="i"
           class="list-group-item"
           href="#/todos">
          <span class="badge" v-if="todo.completed">
            <i class="far fa-check-circle"></i>
          </span>
          {{ todo.title }}
        </a>
      </div>
    </div>
  </div>
</template>
<script>
import axios from 'axios'

export default {
  name: 'todos',
  data: function () {
    return {
      todos: [],
      errors: [],
      isLoading: true,
      endpoint: 'api/faketodos'
    }
  },
  methods: {
    getTodos: function () {
      axios.get(this.endpoint)
        .then(response => {
          this.todos = response.data.todos.map(res => res)

          this.isLoading = false
        })
        .catch(e => {
          this.errors.push(e)
        })
    }
  },
  created: function () {
    this.getTodos()
  }
}
</script>

<style scoped>
  .fa-check-circle {
    font-size: 1.35em
  }
</style>
