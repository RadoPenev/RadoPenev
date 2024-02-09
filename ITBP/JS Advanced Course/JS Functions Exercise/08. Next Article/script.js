
function getArticleGenerator(articles) {
 return ()=>{ 

if(articles.length>0){
let container=document.getElementById('content')
let article=document.createElement('article')
  let currText=articles.shift()
  article.innerText=currText
  container.appendChild(article )
}}
}
