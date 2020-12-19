var shred = require('../model/shred');

function Paper() {
    this.id = 0;
    this.shrederId = '';
    this.hashTags = '';
    this.draft = false;
    this.date = new Date();
}