//if (!String.prototype.supplant) {
//    String.prototype.supplant = function (o) {
//        return this.replace(/{([^{}]*)}/g,
//            function (a, b) {
//                var r = o[b];
//                return typeof r === 'string' || typeof r === 'number' ? r : a;
//            }
//        );
//    };
//}

var variantTable = document.getElementById('variantTable');
var variantTableBody = variantTable.getElementsByTagName('tbody')[0];
var rowTemplate = '<td>{seqNumber}</td><td>{itemID}</td><td>{itemDesc}</td><td>{orderQty}</td><td>{orderSldTdy}</td><td>{availForSaleQty}</td><td>{plannedMins}</td><td>{actualMins}</td>';
//var tickerTemplate = '<span class="newItem">{itemID}</span> <span class="itemDescription">{itemDesc}</span><span class="dir {directionClass}">{direction}</span>';
//var merchTicker = document.getElementById('merchTicker');
//var merchTickerBody = merchTicker.getElementsByTagName('ul')[0];

document.getElementsByClassName("variant").onload = function () {
    connection.invoke("StreamMerchandise");
}

let connection = new signalR.HubConnectionBuilder()
    .withUrl("/merchandise")
    .build();

connection.start().then(function () {
    connection.invoke("StreamMerchandise").then(function (merchandise) {
        for (let i = 0; i < merchandise.length; i++) {
            displayMerch(merchandise[i]);
        }        
    });
    connection.stream("StreamMerchandise").subscribe({
        close: false,
        next: displayMerch,
        error: function (err) {
            logger.log(err);
        }
    });
});



//function startStreaming() {
//    connection.stream("StreamMerchandise").subscribe({
//        close: false,
//        next: displayMerch,
//        error: function (err) {
//            logger.log(err);
//        }
//    });
//}

function displayMerch(merchandise) {
    //var displayMerch = formatMerch(merchandise);
    addOrAppendMerch(variantTableBody, displayMerch, 'td', rowTemplate);
}

function formatMerch(merchandise) {
    merchandise.orderSldTdy += merchandise.orderQty;
    return merchandise;
}

function addOrAppendMerch(table, merchandise, type, template) {
    var child = createMerchNode(merchandise, type, template);

    var merchNode = document.querySelector(type + "[data-itemId" + merchandise.itemId + "]");
    if (merchNode) {
        var change = merchNode.querySelector(".changeValue");
        table.replaceChild(child);
    }
    else {
        table.appendChild(child);
    }
}

function createMerchNode(merchandise, type, template) {
    var child = document.createElement(type);
    child.setAttribute('data-itemId', merchandise.itemId);
    child.innerHTML = template.supplant(merchandise);
    return child;
}