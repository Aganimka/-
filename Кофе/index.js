const f = document.forms[0]
let tr = document.querySelector('#table tr')
let t = tr.parentElement

f.addEventListener('submit', e => {
	e.preventDefault()
	let body = {}
	for (let i = 0; i < f.elements.length; i++) {
		let tag = f[i]
		if (tag.name) {
			if (tag.type === 'radio' && tag.checked) {
				body[tag.name] = tag.value
			} else if (tag.type !== 'radio') {
				body[tag.name] = tag.value
			}
		}
	}
	console.log(body)
	let html = '<tr>'
	html += `<td><img src="${body.image}" width="50" alt="${body.title}"></td>`
	html += `<td>${body.title || ''} </td>`
	html += `<td>${body.sort || ''}  </td>`
	html += `<td>${body.strong || ''}</td>`
	html += `<td>${body.cost || ''}  </td>`
	html += `<td>${body.description || ''}</td>`
	html += '</tr>'
	t.innerHTML += html
	tbody.innerHTML += html;
	f.reset(); 
});

document.getElementById('clearTableButton').addEventListener('click', () => {
	tbody.innerHTML = ''; 

}) 