<script>
    let page = 2;

    document.getElementById("loadMore").addEventListener("click", function () {
        const platform = document.querySelector("[name='platform']").value || "All";
    const search = document.querySelector("[name='search']").value || "";

    fetch(`/Socials?platform=${platform}&search=${search}&page=${page}`)
            .then(response => response.text())
            .then(data => {
                const tempDiv = document.createElement("div");
    tempDiv.innerHTML = data;

                const newPosts = tempDiv.querySelectorAll("#posts > .col");
    const postsContainer = document.getElementById("posts");

    if (newPosts.length === 0) {
        this.disabled = true;
    this.innerText = "No more posts";
    return;
                }

                newPosts.forEach(post => postsContainer.appendChild(post));
    page++;
            })
            .catch(error => {
        console.error("Error loading posts:", error);
            });
    });
</script>
