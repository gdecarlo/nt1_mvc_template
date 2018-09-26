function getLinks(id) {
    let separador = " | ";
    let controller = "libro";
    return `<td><a href="${getAction(controller, "Edit", id)}">Edit</a>${separador}<a href="${getAction(controller, "Details", id)}">Details</a>${separador}<a href="${getAction(controller, "Delete", id)}">Delete</a></td>`;
}

function getAction(controller,method,id) {
    return `${controller}/${method}/${id}`;
}