let array=[]
class List{
    add(element){
      array.push(element)
    }
    remove(index){
      array.splice(index,1)
    }
    get(index){
        return array[index]
    }
    size(){
        return array.length
    }

}
array.sort((a,b)=>a-b)
let list = new List();
list.add(5);
list.add(6);
list.add(7);
console.log(list.get(1)); 
list.remove(1);
console.log(list.get(1));
