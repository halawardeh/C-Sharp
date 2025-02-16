document.getElementById("searchButton").addEventListener("click", function() {
    let searchQuery = document.getElementById("searchInput").value.toLowerCase();

    if (searchQuery.trim() === "") {
        alert("Please enter a search term.");
        return;
    }

    console.log("Searching for:", searchQuery);
    searchItems(searchQuery);
});

function searchItems(query) {
    let items = document.querySelectorAll(".item"); // تأكدي من أن العناصر التي يتم البحث عنها لها الكلاس "item"

    items.forEach(item => {
        let text = item.textContent.toLowerCase();
        if (text.includes(query)) {
            item.style.display = "block";
        } else {
            item.style.display = "none";
        }
    });
}
