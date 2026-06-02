const sizeLabels = ["Small", "Medium", "Large"];

async function loadPizzas() {
  const status = document.getElementById("status");
  const tbody = document.querySelector("#pizza-table tbody");

  try {
    const response = await fetch(`${window.API_BASE_URL}/pizzas`);
    if (!response.ok) {
      throw new Error(`API responded with ${response.status}`);
    }

    const pizzas = await response.json();
    tbody.innerHTML = "";

    pizzas.forEach((pizza) => {
      const row = document.createElement("tr");
      row.innerHTML = `
        <td>${pizza.name}</td>
        <td>${pizza.description}</td>
        <td>${sizeLabels[pizza.size] ?? pizza.size}</td>
        <td>${pizza.price.toFixed(2)}</td>
        <td>${pizza.vegetarian ? "Yes" : "No"}</td>
      `;
      tbody.appendChild(row);
    });

    status.textContent = `Loaded ${pizzas.length} pizzas.`;
  } catch (error) {
    status.textContent = `Could not load pizzas: ${error.message}`;
  }
}

loadPizzas();
