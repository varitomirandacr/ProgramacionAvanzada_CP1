
// Vanilla JS
function showAlert(message) {
	alert(message);
}

async function callEndpoint(url) {
    const _url = url == null ? "http://localhost:63499/Products/Index" : url;
    try {
        debugger;
        const response = await fetch(_url,
            {
                method: "GET",
                headers: {
                    "Content-Type": "application/json",
                }
            });
            /*.then((resp) => {
                debugger;
                return resp.json();
            })
            .then((final) => {
                debugger;
                console.log(final);
            })*/

        if (!response.ok) {
            throw new Error(`Response status: ${response.status}`);
        }
        
        const result = await response.json();

        console.log(result);
    } catch (error) {
        console.error(error.message);
    }
}