function getLinks(id) {
    let separador = " | ";
    let controller = "pelicula";
    return `<td><a href="${getAction("Edit", id)}">Edit</a>${separador}<a href="${getAction("Details", id)}">Details</a>${separador}<a href="${getAction("Delete", id)}">Delete</a></td>`;
}

function getAction(method, id) {
    return `${method}/${id}`;
}