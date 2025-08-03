<template>
  <div class="bg-gray-900 min-w-full min-h-[50px]">
    <h1 class="text-white text-2xl">BombEngine</h1>
  </div>
</template>

<script>
export default {
  mounted() {
    document.title = 'Bombengine'; // set title
  },
};
</script>

<style>
/* You can add global styles here if needed, but Tailwind is designed for utility-first styling directly in the template. */
/* For example, setting the base font-family for the app */
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
}
</style>

