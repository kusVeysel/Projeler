// ========================================
// DEĞİŞKENLER
// ========================================

let products = [];
let filteredProducts = [];
let currentPage = 1;
const productsPerPage = 6;
let cartCount = 0;

// HTML ELEMENTLERİ

const tbody = document.getElementById("tbody");
const searchInput = document.getElementById("searchInput");
const categoryFilter = document.getElementById("categoryFilter");
const sortSelect = document.getElementById("sortSelect");
const clearFilters = document.getElementById("clearFilters");
const productCount = document.getElementById("productCount");
const pagination = document.getElementById("pagination");
const loading = document.getElementById("loading");
const productTable = document.getElementById("productTable");
const emptyMessage = document.getElementById("emptyMessage");
const cartCountElement = document.getElementById("cartCount");

// ========================================
// VERİLERİ ÇEK
// ========================================

async function getProducts() {

    try {

        const response = await fetch("data.json");

        if (!response.ok) {
            throw new Error("Veriler alınamadı.");
        }

        products = await response.json();

        filteredProducts = [...products];

        createCategories();

        calculateStatistics();

        renderProducts();

    } catch (error) {

        console.error(error);

        loading.innerHTML = `

            <div class="text-center text-danger p-5">

                <i class="bi bi-exclamation-triangle fs-1"></i>

                <h4 class="mt-3">
                    Veriler yüklenemedi
                </h4>

                <p>
                    data.json dosyasını kontrol edin.
                </p>

            </div>

        `;

    }
}


// ========================================
// KATEGORİLERİ OLUŞTUR
// ========================================

function createCategories() {

    const categories = [
        ...new Set(
            products.map(product => product.category)
        )
    ];

    categories.sort();

    categories.forEach(category => {

        const option = document.createElement("option");

        option.value = category;

        option.textContent = category;

        categoryFilter.appendChild(option);

    });

}


// ========================================
// İSTATİSTİKLER
// ========================================

function calculateStatistics() {

    // Toplam ürün

    document.getElementById("totalProducts").textContent =
        products.length;


    // Kategori sayısı

    const categories = new Set(
        products.map(product => product.category)
    );

    document.getElementById("totalCategories").textContent =
        categories.size;


    // Ortalama rating

    const totalRating = products.reduce(
        (total, product) => total + product.rating,
        0
    );

    const averageRating =
        totalRating / products.length;

    document.getElementById("averageRating").textContent =
        averageRating.toFixed(1);


    // Toplam stok

    const totalStock = products.reduce(
        (total, product) => total + product.stock,
        0
    );

    document.getElementById("totalStock").textContent =
        totalStock;

}


// ========================================
// ÜRÜNLERİ GÖSTER
// ========================================

function renderProducts() {

    tbody.innerHTML = "";

    const startIndex =
        (currentPage - 1) * productsPerPage;

    const endIndex =
        startIndex + productsPerPage;

    const pageProducts =
        filteredProducts.slice(
            startIndex,
            endIndex
        );


    // Ürün yoksa

    if (pageProducts.length === 0) {

        productTable.style.display = "none";

        emptyMessage.style.display = "block";

        productCount.textContent = "0";

        pagination.innerHTML = "";

        loading.style.display = "none";

        return;

    }


    productTable.style.display = "table";

    emptyMessage.style.display = "none";

    loading.style.display = "none";


    // Ürün sayısı

    productCount.textContent =
        filteredProducts.length;


    // Ürünleri oluştur

    pageProducts.forEach((product, index) => {

        const row = document.createElement("tr");


        // İndirimli fiyat

        const discountedPrice =
            product.price -
            (product.price * product.discount / 100);


        // Stok durumu

        let stockHTML;

        if (product.stock <= 10) {

            stockHTML = `
                <span class="stock-low">
                    ${product.stock}
                </span>
            `;

        } else {

            stockHTML = `
                <span class="stock-good">
                    ${product.stock}
                </span>
            `;

        }


        // Öne çıkan

        const featuredHTML =
            product.isFeatured
                ? `
                    <span class="featured">
                        <i class="bi bi-star-fill"></i>
                        Öne Çıkan
                    </span>
                `
                : "-";


        // İndirim

        let priceHTML;

        if (product.discount > 0) {

            priceHTML = `

                <div class="old-price">
                    ${product.price.toFixed(2)} ₺
                </div>

                <div class="new-price">
                    ${discountedPrice.toFixed(2)} ₺
                </div>

                <span class="badge bg-danger">
                    -%${product.discount}
                </span>

            `;

        } else {

            priceHTML = `

                <div class="new-price">
                    ${product.price.toFixed(2)} ₺
                </div>

            `;

        }


        row.innerHTML = `

            <td>
                ${startIndex + index + 1}
            </td>


            <td class="text-start">

                <div class="d-flex align-items-center gap-3">

                    <img
                        src="${product.image}"
                        class="product-image"
                        alt="${product.name}"
                    >

                    <div>

                        <div class="product-name">
                            ${product.name}
                        </div>

                        <small class="text-muted">
                            ${product.description}
                        </small>

                    </div>

                </div>

            </td>


            <td>

                <span class="badge text-bg-light border">
                    ${product.category}
                </span>

            </td>


            <td>
                ${product.brand}
            </td>


            <td>
                ${priceHTML}
            </td>


            <td>
                ${stockHTML}
            </td>


            <td>

                <span class="text-warning">

                    <i class="bi bi-star-fill"></i>

                </span>

                ${product.rating}

            </td>


            <td>
                ${product.reviewCount}
            </td>


            <td>

                ${product.discount > 0
                    ? `%${product.discount}`
                    : "-"
                }

            </td>


            <td>
                ${featuredHTML}
            </td>


            <td>

                <button
                    class="btn btn-sm btn-outline-danger favorite-btn"
                    title="Favorilere ekle"
                >

                    <i class="bi bi-heart"></i>

                </button>


                <button
                    class="btn btn-sm btn-dark cart-btn"
                    data-id="${product.id}"
                    title="Sepete ekle"
                >

                    <i class="bi bi-cart-plus"></i>

                </button>

            </td>

        `;


        tbody.appendChild(row);

    });


    createPagination();

}


// ========================================
// SAYFALAMA
// ========================================

function createPagination() {

    pagination.innerHTML = "";


    const totalPages =
        Math.ceil(
            filteredProducts.length /
            productsPerPage
        );


    if (totalPages <= 1) {
        return;
    }


    // GERİ

    const previous = document.createElement("li");

    previous.className =
        `page-item ${currentPage === 1 ? "disabled" : ""}`;

    previous.innerHTML = `

        <a class="page-link" href="#">
            <i class="bi bi-chevron-left"></i>
        </a>

    `;

    previous.addEventListener("click", function (event) {

        event.preventDefault();

        if (currentPage > 1) {

            currentPage--;

            renderProducts();

        }

    });

    pagination.appendChild(previous);


    // SAYFALAR

    for (let i = 1; i <= totalPages; i++) {

        const page = document.createElement("li");

        page.className =
            `page-item ${i === currentPage ? "active" : ""}`;

        page.innerHTML = `

            <a class="page-link" href="#">
                ${i}
            </a>

        `;


        page.addEventListener("click", function (event) {

            event.preventDefault();

            currentPage = i;

            renderProducts();

        });


        pagination.appendChild(page);

    }


    // İLERİ

    const next = document.createElement("li");

    next.className =
        `page-item ${
            currentPage === totalPages
                ? "disabled"
                : ""
        }`;


    next.innerHTML = `

        <a class="page-link" href="#">
            <i class="bi bi-chevron-right"></i>
        </a>

    `;


    next.addEventListener("click", function (event) {

        event.preventDefault();


        if (currentPage < totalPages) {

            currentPage++;

            renderProducts();

        }

    });


    pagination.appendChild(next);

}


// ========================================
// FİLTRELEME
// ========================================

function filterProducts() {

    const searchValue =
        searchInput.value
            .toLowerCase()
            .trim();


    const categoryValue =
        categoryFilter.value;


    filteredProducts =
        products.filter(product => {

            const searchMatch =

                product.name
                    .toLowerCase()
                    .includes(searchValue)

                ||

                product.brand
                    .toLowerCase()
                    .includes(searchValue)

                ||

                product.category
                    .toLowerCase()
                    .includes(searchValue);


            const categoryMatch =

                categoryValue === "all"

                ||

                product.category === categoryValue;


            return searchMatch && categoryMatch;

        });


    sortProducts();

}


// ========================================
// SIRALAMA
// ========================================

function sortProducts() {

    const sortValue =
        sortSelect.value;


    if (sortValue === "price-low") {

        filteredProducts.sort(
            (a, b) => a.price - b.price
        );

    }


    else if (sortValue === "price-high") {

        filteredProducts.sort(
            (a, b) => b.price - a.price
        );

    }


    else if (sortValue === "rating") {

        filteredProducts.sort(
            (a, b) => b.rating - a.rating
        );

    }


    else if (sortValue === "stock") {

        filteredProducts.sort(
            (a, b) => b.stock - a.stock
        );

    }


    currentPage = 1;

    renderProducts();

}


// ========================================
// FİLTRELERİ TEMİZLE
// ========================================

clearFilters.addEventListener("click", function () {

    searchInput.value = "";

    categoryFilter.value = "all";

    sortSelect.value = "default";

    filteredProducts = [...products];

    currentPage = 1;

    renderProducts();

});


// ========================================
// ARAMA
// ========================================

searchInput.addEventListener(
    "input",
    filterProducts
);


// ========================================
// KATEGORİ
// ========================================

categoryFilter.addEventListener(
    "change",
    filterProducts
);


// ========================================
// SIRALAMA
// ========================================

sortSelect.addEventListener(
    "change",
    sortProducts
);


// ========================================
// SEPET
// ========================================

tbody.addEventListener("click", function (event) {

    const button =
        event.target.closest(".cart-btn");


    if (!button) {
        return;
    }


    cartCount++;

    cartCountElement.textContent =
        cartCount;


    button.classList.remove("btn-dark");

    button.classList.add("btn-success");


    button.innerHTML = `
        <i class="bi bi-check-lg"></i>
    `;


    setTimeout(() => {

        button.classList.remove("btn-success");

        button.classList.add("btn-dark");


        button.innerHTML = `
            <i class="bi bi-cart-plus"></i>
        `;

    }, 1000);

});


// ========================================
// FAVORİ
// ========================================

tbody.addEventListener("click", function (event) {

    const button =
        event.target.closest(".favorite-btn");


    if (!button) {
        return;
    }


    const icon =
        button.querySelector("i");


    if (icon.classList.contains("bi-heart")) {

        icon.classList.remove("bi-heart");

        icon.classList.add("bi-heart-fill");

        button.classList.remove(
            "btn-outline-danger"
        );

        button.classList.add(
            "btn-danger"
        );

    } else {

        icon.classList.remove(
            "bi-heart-fill"
        );

        icon.classList.add(
            "bi-heart"
        );

        button.classList.remove(
            "btn-danger"
        );

        button.classList.add(
            "btn-outline-danger"
        );

    }

});


// ========================================
// BAŞLAT
// ========================================

getProducts();