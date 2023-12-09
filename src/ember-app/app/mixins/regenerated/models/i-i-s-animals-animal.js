import Mixin from '@ember/object/mixin';
import $ from 'jquery';
import DS from 'ember-data';
import { validator } from 'ember-cp-validations';
import { attr, belongsTo, hasMany } from 'ember-flexberry-data/utils/attributes';

export let Model = Mixin.create({
  name: DS.attr('string'),
  burrows: DS.hasMany('i-i-s-animals-burrow', { inverse: 'animal', async: false })
});

export let ValidationRules = {
  name: {
    descriptionKey: 'models.i-i-s-animals-animal.validations.name.__caption__',
    validators: [
      validator('ds-error'),
    ],
  },
  burrows: {
    descriptionKey: 'models.i-i-s-animals-animal.validations.burrows.__caption__',
    validators: [
      validator('ds-error'),
      validator('has-many'),
    ],
  },
};

export let defineProjections = function (modelClass) {
  modelClass.defineProjection('AnimalE', 'i-i-s-animals-animal', {
    name: attr('Name', { index: 0 }),
    burrows: hasMany('i-i-s-animals-burrow', 'Burrows', {
      name: attr('Name', { index: 0 }),
      forest: belongsTo('i-i-s-animals-forest', 'Forest', {
        name: attr('Name', { index: 2, hidden: true })
      }, { index: 1, displayMemberPath: 'name' })
    })
  });

  modelClass.defineProjection('AnimalL', 'i-i-s-animals-animal', {
    name: attr('Name', { index: 0 })
  });
};
